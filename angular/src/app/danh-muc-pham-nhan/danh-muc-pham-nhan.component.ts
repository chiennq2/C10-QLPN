import { Component, Injector, ChangeDetectorRef, ViewChild } from '@angular/core';
import { finalize } from 'rxjs/operators';
import { BsModalRef, BsModalService } from 'ngx-bootstrap/modal';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import { PagedListingComponentBase } from '@shared/paged-listing-component-base';
import { DanhMucPhamNhanDto, DanhMucPhamNhanService } from './danh-muc-pham-nhan.service';
import { CreateDanhMucPhamNhanDialogComponent } from './create-danh-muc-pham-nhan/create-danh-muc-pham-nhan-dialog.component';
import { EditDanhMucPhamNhanDialogComponent } from './edit-danh-muc-pham-nhan/edit-danh-muc-pham-nhan-dialog.component';
import { Table, TableModule } from 'primeng/table';
import { LazyLoadEvent, PrimeTemplate } from 'primeng/api';
import { ActivatedRoute } from '@angular/router';
import { Paginator, PaginatorModule } from 'primeng/paginator';
import { FormsModule } from '@angular/forms';
import { NgIf } from '@angular/common';
import { LocalizePipe } from '@shared/pipes/localize.pipe';

@Component({
    templateUrl: './danh-muc-pham-nhan.component.html',
    animations: [appModuleAnimation()],
    standalone: true,
    imports: [FormsModule, TableModule, PrimeTemplate, NgIf, PaginatorModule, LocalizePipe],
})
export class DanhMucPhamNhanComponent extends PagedListingComponentBase<DanhMucPhamNhanDto> {
    @ViewChild('dataTable', { static: true }) dataTable: Table;
    @ViewChild('paginator', { static: true }) paginator: Paginator;

    keyword = '';

    constructor(
        injector: Injector,
        private _danhMucPhamNhanService: DanhMucPhamNhanService,
        private _modalService: BsModalService,
        private _activatedRoute: ActivatedRoute,
        cd: ChangeDetectorRef
    ) {
        super(injector, cd);
        this.keyword = this._activatedRoute.snapshot.queryParams['keyword'] || '';
    }

    list(event?: LazyLoadEvent): void {
        if (this.primengTableHelper.shouldResetPaging(event)) {
            this.paginator.changePage(0);

            if (this.primengTableHelper.records && this.primengTableHelper.records.length > 0) {
                return;
            }
        }

        this.primengTableHelper.showLoadingIndicator();

        this._danhMucPhamNhanService
            .getAll({
                keyword: this.keyword,
                sorting: this.primengTableHelper.getSorting(this.dataTable),
                skipCount: this.primengTableHelper.getSkipCount(this.paginator, event),
                maxResultCount: this.primengTableHelper.getMaxResultCount(this.paginator, event),
            })
            .pipe(
                finalize(() => {
                    this.primengTableHelper.hideLoadingIndicator();
                })
            )
            .subscribe((result) => {
                this.primengTableHelper.records = result.items;
                this.primengTableHelper.totalRecordsCount = result.totalCount;
                this.cd.detectChanges();
            });
    }

    delete(item: DanhMucPhamNhanDto): void {
        abp.message.confirm(this.l('AreYouSureWantToDelete', item.noiDung), undefined, (result: boolean) => {
            if (result) {
                this._danhMucPhamNhanService
                    .delete(item.id)
                    .pipe(
                        finalize(() => {
                            abp.notify.success(this.l('SuccessfullyDeleted'));
                            this.refresh();
                        })
                    )
                    .subscribe(() => {});
            }
        });
    }

    createDanhMucPhamNhan(): void {
        this.showCreateOrEditDialog();
    }

    editDanhMucPhamNhan(item: DanhMucPhamNhanDto): void {
        this.showCreateOrEditDialog(item.id);
    }

    private showCreateOrEditDialog(id?: number): void {
        let dialog: BsModalRef;
        if (!id) {
            dialog = this._modalService.show(CreateDanhMucPhamNhanDialogComponent, {
                class: 'modal-lg',
            });
        } else {
            dialog = this._modalService.show(EditDanhMucPhamNhanDialogComponent, {
                class: 'modal-lg',
                initialState: {
                    id: id,
                },
            });
        }

        dialog.content.onSave.subscribe(() => {
            this.refresh();
        });
    }
}
