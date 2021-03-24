import { Component, OnInit } from '@angular/core';
import { Brand } from 'src/app/models/brand';
import { Car } from 'src/app/models/car';
import { Customer } from 'src/app/models/customer';
import { RentDetailDto } from 'src/app/models/rentDetailDto';
import { User } from 'src/app/models/user';
import { BrandService } from 'src/app/services/brand.service';
import { CarService } from 'src/app/services/car.service';
import { CustomerService } from 'src/app/services/customer.service';
import { UserService } from 'src/app/services/user.service';

@Component({
  selector: 'app-rental-register',
  templateUrl: './rental-register.component.html',
  styleUrls: ['./rental-register.component.css'],
  providers: [BrandService, CustomerService],
})
export class RentalRegisterComponent implements OnInit {
  constructor(
    private brandService: BrandService,
    private customerService: CustomerService,
    private carService: CarService,
    private userService: UserService
  ) {}

  model: RentDetailDto[] = [];
  cars: Car[] = [];
  brands: Brand[] = [];
  customers: Customer[] = [];
  users: User[] = [];
  ngOnInit(): void {
    this.getBrands();
    this.getCustomer();
    this.getCar();
    this.getUser();
  }

  getBrands() {
    this.brandService.getBrands().subscribe((response) => {
      this.brands = response.data;
    });
  }
  getCustomer() {
    this.customerService.getCustomer().subscribe((response) => {
      this.customers = response.data;
    });
  }
  getCar() {
    this.carService.getCar().subscribe((response) => {
      this.cars = response.data;
    });
  }
  getUser() {
    this.userService.getUser().subscribe((response) => {
      this.users = response.data;
    });
  }
}
