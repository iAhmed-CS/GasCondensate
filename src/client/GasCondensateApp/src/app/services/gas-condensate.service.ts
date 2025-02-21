import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http'
import { Observable } from 'rxjs';
import { GasCondensate } from '../models/gas-condensate.model';
import { DisplayGasCondensateListResponse } from '../models/display-gas-condensate-list-response.model';

const httpOptions = {
  headers: new HttpHeaders({
    'Content-Type': 'application/json',
  }),
};

@Injectable({
  providedIn: 'root'
})
export class GasCondensateService {
  apiUrl = 'http://localhost:5025';


  constructor(private http: HttpClient) { }

  getGasCondensateList(): Observable<DisplayGasCondensateListResponse> {
    return this.http.get<DisplayGasCondensateListResponse>(`${this.apiUrl}/DisplayGasCondensateList`);
  }

  addGasCondensate(gasCondensate: GasCondensate): Observable<any> {
    return this.http.post<any>(`${this.apiUrl}/CreateGasCondensate`, gasCondensate, httpOptions)
  }

  deleteGasCondensate(gasCondensateId: string): Observable<any> {
    return this.http.delete<any>(`${this.apiUrl}/DeleteGasCondensate/${gasCondensateId}`);
  }

  updateGasCondensate(gasCondensate: GasCondensate): Observable<any> {
    return this.http.put<any>(`${this.apiUrl}/UpdateGasCondensate`, gasCondensate, httpOptions)
  }
}
