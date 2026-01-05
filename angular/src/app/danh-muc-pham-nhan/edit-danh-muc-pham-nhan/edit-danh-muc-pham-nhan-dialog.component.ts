import { Component, Injector, OnInit, Output, EventEmitter, ChangeDetectorRef } from '@angular/core';
import { BsModalRef } from 'ngx-bootstrap/modal';
import { AppComponentBase } from '@shared/app-component-base';
import { DanhMucPhamNhanDto, DanhMucPhamNhanService } from '../danh-muc-pham-nhan.service';
import { FormsModule } from '@angular/forms';
import { AbpModalHeaderComponent } from '../../../shared/components/modal/abp-modal-header.component';
import { AbpValidationSummaryComponent } from '../../../shared/components/validation/abp-validation.summary.component';
import { AbpModalFooterComponent } from '../../../shared/components/modal/abp-modal-footer.component';
import { LocalizePipe } from '@shared/pipes/localize.pipe';

@Component({
    templateUrl: 'edit-danh-muc-pham-nhan-dialog.component.html',
    standalone: true,
    imports: [
        FormsModule,
        AbpModalHeaderComponent,
        AbpValidationSummaryComponent,
        AbpModalFooterComponent,
        LocalizePipe,
    ],
})
export class EditDanhMucPhamNhanDialogComponent extends AppComponentBase implements OnInit {
    @Output() onSave = new EventEmitter<any>();

    saving = false;
    item: DanhMucPhamNhanDto = {
        id: 0,
        code: '',
        noiDung: '',
        isActive: true,
    };
    id: number;

    constructor(
        injector: Injector,
        private _danhMucPhamNhanService: DanhMucPhamNhanService,
        public bsModalRef: BsModalRef,
        private cd: ChangeDetectorRef
    ) {
        super(injector);
    }

    ngOnInit(): void {
        this._danhMucPhamNhanService.get(this.id).subscribe((result) => {
            this.item = result;
            this.cd.detectChanges();
        });
    }

    save(): void {
        this.saving = true;

        this._danhMucPhamNhanService.update(this.item).subscribe(
            () => {
                this.notify.info(this.l('SavedSuccessfully'));
                this.bsModalRef.hide();
                this.onSave.emit();
            },
            () => {
                this.saving = false;
            }
        );
    }
}
