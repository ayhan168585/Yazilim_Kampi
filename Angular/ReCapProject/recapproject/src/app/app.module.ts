import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import {HttpClientModule} from '@angular/common/http';
import {FormsModule,ReactiveFormsModule} from '@angular/forms';
import {BrowserAnimationsModule} from '@angular/platform-browser/animations'

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { CarComponent } from './components/car/car.component';
import { BrandComponent } from './components/brand/brand.component';
import { ColorComponent } from './components/color/color.component';
import { NavComponent } from './components/nav/nav.component';
import { CustomerComponent } from './components/customer/customer.component';
import { RentalComponent } from './components/rental/rental.component';
import { CarDetailComponent } from './components/car-detail/car-detail.component';
import { VatAddedPipe } from './pipes/vat-added.pipe';
import { FilterPipePipe } from './pipes/filter-pipe.pipe';
import { FilterBrandPipePipe } from './pipes/filter-brand-pipe.pipe';
import { FilterColorPipePipe } from './pipes/filter-color-pipe.pipe';

import {ToastrModule} from 'ngx-toastr';
import { CarFilterComponent } from './components/car-filter/car-filter.component';
import { RentalRegisterComponent } from './components/rental/rental-register/rental-register.component';
import { UserComponent } from './components/user/user.component';
import { BrandRegisterComponent } from './components/brand/brand-register/brand-register.component';
import { ColorRegisterComponent } from './components/color/color-register/color-register.component';
import { CarRegisterComponent } from './components/car/car-register/car-register.component';

@NgModule({
  declarations: [
    AppComponent,
    CarComponent,
    BrandComponent,
    ColorComponent,
    NavComponent,
    CustomerComponent,
    RentalComponent,
    CarDetailComponent,
    VatAddedPipe,
    FilterPipePipe,
    FilterBrandPipePipe,
    FilterColorPipePipe,
    CarFilterComponent,
    RentalRegisterComponent,
    UserComponent,
    BrandRegisterComponent,
    ColorRegisterComponent,
    CarRegisterComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule,
    BrowserAnimationsModule,
    ToastrModule.forRoot({
      positionClass:"toast-bottom-right"
    })
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
