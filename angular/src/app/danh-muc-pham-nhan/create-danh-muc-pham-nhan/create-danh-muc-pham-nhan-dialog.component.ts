import { Component, Injector, OnInit, Output, EventEmitter, ChangeDetectorRef } from '@angular/core';
import { BsModalRef } from 'ngx-bootstrap/modal';
import { AppComponentBase } from '@shared/app-component-base';
import { CreateDanhMucPhamNhanDto, DanhMucPhamNhanService } from '../danh-muc-pham-nhan.service';
import { FormsModule } from '@angular/forms';
import { AbpModalHeaderComponent } from '../../../shared/components/modal/abp-modal-header.component';
import { AbpValidationSummaryComponent } from '../../../shared/components/validation/abp-validation.summary.component';
import { AbpModalFooterComponent } from '../../../shared/components/modal/abp-modal-footer.component';
import { LocalizePipe } from '@shared/pipes/localize.pipe';

@Component({
    templateUrl: 'create-danh-muc-pham-nhan-dialog.component.html',
    standalone: true,
    imports: [
        FormsModule,
        AbpModalHeaderComponent,
        AbpValidationSummaryComponent,
        AbpModalFooterComponent,
        LocalizePipe,
    ],
})
export class CreateDanhMucPhamNhanDialogComponent extends AppComponentBase implements OnInit {
    @Output() onSave = new EventEmitter<any>();

    saving = false;
    item: CreateDanhMucPhamNhanDto = {
        code: '',
        noiDung: '',
        isActive: true,
    };

    constructor(
        injector: Injector,
        private _danhMucPhamNhanService: DanhMucPhamNhanService,
        public bsModalRef: BsModalRef,
        private cd: ChangeDetectorRef
    ) {
        super(injector);
    }

    ngOnInit(): void {
        this.cd.detectChanges();
    }

    save(): void {
        this.saving = true;

        this._danhMucPhamNhanService.create(this.item).subscribe(
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
