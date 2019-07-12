import { Injectable } from '@angular/core';
import { HttpClient, HttpEventType  } from '@angular/common/http';
import { map } from 'rxjs/internal/operators/map';

@Injectable({
  providedIn: 'root'
})
export class DebitOrdersService {

  baseUrl = 'http://localhost:49650/api/';
  constructor(private http: HttpClient) { }

  saveDebitOrders(debitOrder: any) {
    return this.http.post(this.baseUrl + 'DebitOrders/action', debitOrder);
  }

  GetDebitOrders() {
    return this.http.get(this.baseUrl + 'debitInstructions/getInstructions');
  }

  upload(data) {
    const uploadUrl = this.baseUrl + 'debitInstructions/importTransactions';

    return this.http.post<any>(uploadUrl, data, {
      reportProgress: true,
      observe: 'events',
     /*  headers: new HttpHeaders ( {
        'Authorization': 'Bearer ' + localStorage.getItem('token')
      }) */
    }).pipe(map((event) => {
      switch (event.type) {

        case HttpEventType.UploadProgress:
          const progress = Math.round(100 * event.loaded / event.total);
          return { status: 'progress', message: progress };

        case HttpEventType.Response:
          return event.body;

        default:
            return `Unhandled event: ${event.type}`;

      }
    })
    );
  }

}
