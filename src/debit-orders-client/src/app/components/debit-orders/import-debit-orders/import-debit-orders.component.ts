import { Component, OnInit } from '@angular/core';
import { DebitOrdersService } from 'src/app/_services/debit-orders.service';

@Component({
  selector: 'app-import-debit-orders',
  templateUrl: './import-debit-orders.component.html',
  styleUrls: ['./import-debit-orders.component.css']
})
export class ImportDebitOrdersComponent implements OnInit {
  file: any;
  error: string;
  uploadResponse = { status: '', message: '', filePath: ''};
  constructor(private debitOrderSvc: DebitOrdersService) { }

  ngOnInit() {
  }

  onFileChange(event) {
    if (event.target.files.length > 0) {
       this.file = event.target.files[0];
       alert('File Changed');
    }
  }

  submitFile() {

    const formData = new FormData();
    formData.append('file', this.file);

    this.debitOrderSvc.upload(formData).subscribe(
      (res) => this.uploadResponse = res,
      (err) => this.error = err
    );

  }

}
