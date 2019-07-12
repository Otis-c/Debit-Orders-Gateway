import { Routes, RouterModule } from '@angular/router';
import { CreateDebitOrdersComponent } from './components/debit-orders/create-debit-orders/create-debit-orders.component';
import { DebitOrderListComponent } from './components/debit-orders/debit-order-list/debit-order-list.component';
import { ImportDebitOrdersComponent } from './components/debit-orders/import-debit-orders/import-debit-orders.component';

export const appRoutes: Routes = [
  { path: '', component: DebitOrderListComponent},
  { path: 'newInstruction', component: CreateDebitOrdersComponent },
  { path: 'debitOrders', component: DebitOrderListComponent },
  { path: 'import', component: ImportDebitOrdersComponent },
  { path: '**', redirectTo: '', pathMatch: 'full' }
];
