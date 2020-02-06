import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule } from '@angular/forms';
import { BsDropdownModule } from 'ngx-bootstrap';
import { RouterModule } from '@angular/router';


import { AppComponent } from './app.component';
import { NavComponent } from './nav/nav.component';
import { AuthService } from './_services/auth.service';
import { HomeComponent } from './home/home.component';
import { RegisterComponent } from './register/register.component';
import { ErrorInterceptorProvider } from './_services/error.interceptor';

import { appRoutes } from './routes';
import { LeaseAgreementComponent } from './lease-agreement/lease-agreement.component';
import { ContactComponent } from './contact/contact.component';
import { RentedCarListComponent } from './rented-car-list/rented-car-list.component';
import { UserService } from './_services/user.service';
import { CarService } from './_services/car.service';
import { CarListComponent } from './cars/car-list/car-list.component';
import { CarCardComponent } from './cars/car-card/car-card.component';

@NgModule({
   declarations: [
      AppComponent,
      NavComponent,
      HomeComponent,
      RegisterComponent,
      CarListComponent,
      CarCardComponent,
      LeaseAgreementComponent,
      ContactComponent,
      RentedCarListComponent
   ],
   imports: [
      BrowserModule,
      HttpClientModule,
      FormsModule,
      BsDropdownModule.forRoot(),
      RouterModule.forRoot(appRoutes)
   ],
   providers: [
      AuthService,
      CarService,
      UserService,
      ErrorInterceptorProvider
   ],
   bootstrap: [
      AppComponent
   ]
})
export class AppModule { }
