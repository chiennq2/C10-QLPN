import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { Observable } from 'rxjs';
import { AppConsts } from '@shared/AppConsts';

export interface DanhMucPhamNhanDto {
    id: number;
    code: string;
    noiDung: string;
    isActive: boolean;
}

export interface CreateDanhMucPhamNhanDto {
    code: string;
    noiDung: string;
    isActive: boolean;
}

export interface PagedDanhMucPhamNhanRequestDto {
    keyword?: string;
    isActive?: boolean;
    sorting?: string;
    skipCount?: number;
    maxResultCount?: number;
}

export interface PagedResultDto<T> {
    items: T[];
    totalCount: number;
}

@Injectable({
    providedIn: 'root',
})
export class DanhMucPhamNhanService {
    private baseUrl = `${AppConsts.remoteServiceBaseUrl}/api/services/app/DanhMucPhamNhan`;

    constructor(private http: HttpClient) {}

    getAll(input: PagedDanhMucPhamNhanRequestDto): Observable<PagedResultDto<DanhMucPhamNhanDto>> {
        let params = new HttpParams();

        if (input.keyword) {
            params = params.set('Keyword', input.keyword);
        }

        if (input.sorting) {
            params = params.set('Sorting', input.sorting);
        }

        if (input.skipCount !== undefined && input.skipCount !== null) {
            params = params.set('SkipCount', input.skipCount.toString());
        }

        if (input.maxResultCount !== undefined && input.maxResultCount !== null) {
            params = params.set('MaxResultCount', input.maxResultCount.toString());
        }

        if (input.isActive !== undefined && input.isActive !== null) {
            params = params.set('IsActive', input.isActive.toString());
        }

        return this.http.get<PagedResultDto<DanhMucPhamNhanDto>>(`${this.baseUrl}/GetAll`, { params });
    }

    get(id: number): Observable<DanhMucPhamNhanDto> {
        const params = new HttpParams().set('Id', id.toString());
        return this.http.get<DanhMucPhamNhanDto>(`${this.baseUrl}/Get`, { params });
    }

    create(input: CreateDanhMucPhamNhanDto): Observable<DanhMucPhamNhanDto> {
        return this.http.post<DanhMucPhamNhanDto>(`${this.baseUrl}/Create`, input);
    }

    update(input: DanhMucPhamNhanDto): Observable<DanhMucPhamNhanDto> {
        return this.http.put<DanhMucPhamNhanDto>(`${this.baseUrl}/Update`, input);
    }

    delete(id: number): Observable<void> {
        const params = new HttpParams().set('Id', id.toString());
        return this.http.delete<void>(`${this.baseUrl}/Delete`, { params });
    }
}
