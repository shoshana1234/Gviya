import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ResidentsService {

  constructor(private httpClient: HttpClient) { }

  getResidents(): Observable<any> {
    return this.httpClient.get<any>('https://localhost:44353/api/Residents');
  }
  getPaymentsPerResident(id: number): Observable<any> {
    return this.httpClient.get<any>('https://localhost:44353/api/Residents/' + id);
  }
    addPaymentPerResident(id: number,payment:any): Observable<any> {
    return this.httpClient.post<any>('https://localhost:44353/api/Residents/' + id,payment);
  }
}
