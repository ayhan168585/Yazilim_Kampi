import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { BrandRegisterComponent } from './components/brand/brand-register/brand-register.component';
import { CarDetailComponent } from './components/car-detail/car-detail.component';
import { CarRegisterComponent } from './components/car/car-register/car-register.component';
import { CarComponent } from './components/car/car.component';
import { ColorRegisterComponent } from './components/color/color-register/color-register.component';
import { RentalRegisterComponent } from './components/rental/rental-register/rental-register.component';
import { RentalComponent } from './components/rental/rental.component';

const routes: Routes = [
  {path:"",pathMatch:"full",component:CarComponent},
  {path:"cars",component:CarComponent},
  {path:"cars/cars-register",component:CarRegisterComponent},
  {path:"cars/brand/:brandId",component:CarComponent},
  {path:"cars/brand-register",component:BrandRegisterComponent},
  {path:"cars/color/:colorId",component:CarComponent},
  {path:"cars/details/:carId", component:CarDetailComponent},
  {path:"cars/car/:carId",component:CarDetailComponent},
  {path:"cars/cardetails/:carId",component:CarDetailComponent},
  {path:"cars/rentals",component:RentalComponent},
  {path:"cars/rental-register",component:RentalRegisterComponent},
  {path:"cars/color-register",component:ColorRegisterComponent},
  {path:"cars/rentals/customer/:id",component:RentalComponent},
  {path:"cars/filter/:brandId/:colorId",component:CarComponent}


];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
