import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { ReactiveFormsModule } from '@angular/forms';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { RouterModule } from '@angular/router';
import { HttpClientModule } from '@angular/common/http';

import { BsDatepickerModule } from 'ngx-bootstrap/datepicker';

import { AppComponent } from './app.component';
import { HeaderComponent } from './components/nav/header/header.component';
import { SideBarComponent } from './components/nav/side-bar/side-bar.component';
import { PageHeaderComponent } from './components/nav/page-header/page-header.component';
import { LoginComponent } from './components/auth/login/login.component';
import { CreateDebitOrdersComponent } from './components/debit-orders/create-debit-orders/create-debit-orders.component';
import { appRoutes } from './routes';
import { DebitOrdersService } from './_services/debit-orders.service';
import { DebitOrderListComponent } from './components/debit-orders/debit-order-list/debit-order-list.component';
import { ImportDebitOrdersComponent } from './components/debit-orders/import-debit-orders/import-debit-orders.component';

@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
    SideBarComponent,
    PageHeaderComponent,
    LoginComponent,
    CreateDebitOrdersComponent,
    DebitOrderListComponent,
    ImportDebitOrdersComponent
  ],
  imports: [
    BrowserModule,
    BsDatepickerModule.forRoot(),
    BrowserAnimationsModule,
    ReactiveFormsModule,
    HttpClientModule,
    RouterModule.forRoot(appRoutes)
  ],
  providers: [
    DebitOrdersService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
