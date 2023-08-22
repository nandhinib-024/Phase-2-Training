import { Routes } from "@angular/router";
import { HomeComponent } from "./app/home/home.component";
import { ContactComponent } from "./app/contact/contact.component";
import { ProductComponent } from "./app/product/product.component";
import { BugsComponent } from "./app/bugs/bugs.component";


export const appRoutes: Routes = 
[
    { path: 'home', component: HomeComponent },
    { path: 'contact', component: ContactComponent },
    { path: 'product', component: ProductComponent },
    { path: '', redirectTo: 'home', pathMatch: 'full' },  //default route 
    { path: '**', component: BugsComponent }   //wild card route
  ];