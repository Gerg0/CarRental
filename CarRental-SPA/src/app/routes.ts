import {Routes} from '@angular/router';
import { HomeComponent } from './home/home.component';

import { ContactComponent } from './contact/contact.component';
import { LeaseAgreementComponent } from './lease-agreement/lease-agreement.component';
import { RentedCarListComponent } from './rented-car-list/rented-car-list.component';
import { AuthGuard } from './_guards/auth.guard';
import { CarListComponent } from './cars/car-list/car-list.component';

export const appRoutes: Routes = [
    {path: '', component: HomeComponent},
    {
        path: '',
        runGuardsAndResolvers: 'always',
        canActivate: [AuthGuard],
        children: [
            {path: 'cars', component: CarListComponent},
            {path: 'rentedcars', component: RentedCarListComponent, canActivate: [AuthGuard]},
            {path: 'contact', component: ContactComponent},
            {path: 'lease-agreement', component: LeaseAgreementComponent},
        ]
    },
    {path: '**', redirectTo: '', pathMatch: 'full'}
];
