import { Component, OnInit } from '@angular/core';
import { DebitOrdersService } from 'src/app/_services/debit-orders.service';

@Component({
  selector: 'app-debit-order-list',
  templateUrl: './debit-order-list.component.html',
  styleUrls: ['./debit-order-list.component.css']
})
export class DebitOrderListComponent implements OnInit {
  instructions: any = [];
  constructor(private debitOrderSvc: DebitOrdersService) { }

  ngOnInit() {
    this.debitOrderSvc.GetDebitOrders().subscribe((result: any) => {
      console.log(result);
      this.instructions = result;
    }, error => {
      console.log(error);
    });
  }

}
