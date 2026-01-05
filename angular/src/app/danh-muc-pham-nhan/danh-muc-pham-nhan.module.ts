import { NgModule } from '@angular/core';
import { SharedModule } from '@shared/shared.module';
import { CommonModule } from '@angular/common';
import { DanhMucPhamNhanRoutingModule } from './danh-muc-pham-nhan-routing.module';
import { DanhMucPhamNhanComponent } from './danh-muc-pham-nhan.component';
import { CreateDanhMucPhamNhanDialogComponent } from './create-danh-muc-pham-nhan/create-danh-muc-pham-nhan-dialog.component';
import { EditDanhMucPhamNhanDialogComponent } from './edit-danh-muc-pham-nhan/edit-danh-muc-pham-nhan-dialog.component';

@NgModule({
    imports: [
        SharedModule,
        CommonModule,
        DanhMucPhamNhanRoutingModule,
        DanhMucPhamNhanComponent,
        CreateDanhMucPhamNhanDialogComponent,
        EditDanhMucPhamNhanDialogComponent,
    ],
})
export class DanhMucPhamNhanModule {}
