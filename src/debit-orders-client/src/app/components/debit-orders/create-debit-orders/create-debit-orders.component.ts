import { Component, OnInit } from '@angular/core';
import { BsDatepickerConfig } from 'ngx-bootstrap/datepicker/public_api';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { DebitOrdersService } from 'src/app/_services/debit-orders.service';

@Component({
  selector: 'app-create-debit-orders',
  templateUrl: './create-debit-orders.component.html',
  styleUrls: ['./create-debit-orders.component.css']
})
export class CreateDebitOrdersComponent implements OnInit {
  bsConfig: Partial<BsDatepickerConfig>;
  bsValue = new Date();
  file: any;
  debitOrderForm: FormGroup;

  constructor(private formBuilder: FormBuilder, private debitOrderSvc: DebitOrdersService) { }

  ngOnInit() {
    this.bsConfig = {
      dateInputFormat: 'DD/MM/YYYY', isAnimated: true, adaptivePosition: true
    };

    this.debitOrderForm = this.formBuilder.group({
      accountName: ['', Validators.required],
      idNumber: ['', Validators.required],
      accountNumber: ['', Validators.required],
      branchCode: ['', Validators.required],
      bankCode: ['', Validators.required],
      debitAmount: ['', Validators.required],
      debitNarration: ['', Validators.required],
      startDate: [new Date(), Validators.required],
      endDate: [new Date(), Validators.required],
      processingDay: ['', Validators.required],
      creditor: ['', Validators.required]
    });
  }



  onDebitOrderSubmit() {
    console.log(this.debitOrderForm.value);
    this.debitOrderSvc.saveDebitOrders(this.debitOrderForm.value).subscribe((result: any) => {
      console.log(result);
    }, error => {
      console.log(error);
    });
  }



}
