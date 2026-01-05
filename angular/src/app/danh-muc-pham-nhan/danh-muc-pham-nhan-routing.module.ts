import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { DanhMucPhamNhanComponent } from './danh-muc-pham-nhan.component';

const routes: Routes = [
    {
        path: '',
        component: DanhMucPhamNhanComponent,
        pathMatch: 'full',
    },
];

@NgModule({
    imports: [RouterModule.forChild(routes)],
    exports: [RouterModule],
})
export class DanhMucPhamNhanRoutingModule {}
