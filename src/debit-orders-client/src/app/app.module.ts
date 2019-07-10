import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { HeaderComponent } from './components/nav/header/header.component';
import { SideBarComponent } from './components/nav/side-bar/side-bar.component';
import { PageHeaderComponent } from './components/nav/page-header/page-header.component';
import { LoginComponent } from './components/auth/login/login.component';
import { CreateDebitOrdersComponent } from './components/debit-orders/create-debit-orders/create-debit-orders.component';

@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
    SideBarComponent,
    PageHeaderComponent,
    LoginComponent,
    CreateDebitOrdersComponent
  ],
  imports: [
    BrowserModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
