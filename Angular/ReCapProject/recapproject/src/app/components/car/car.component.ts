import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Car } from 'src/app/models/car';
import { CarService } from 'src/app/services/car.service';

@Component({
  selector: 'app-car',
  templateUrl: './car.component.html',
  styleUrls: ['./car.component.css'],
})
export class CarComponent implements OnInit {
  cars: Car[] = [];
  filterText="";
  filterBrandText="";
  filterColorText:"";

  constructor(
    private carService: CarService,
    private activatedRoute: ActivatedRoute
  ) {}

  ngOnInit(): void {
    this.activatedRoute.params.subscribe((params) => {
      if (params['brandId']) {
        this.getCarByBrand(params['brandId']);
      } else if (params['colorId']) {
        this.getCarByColor(params['colorId']);
      } else if (params['carId']) {
        this.getCarById(params['carId']);
      } else {
        this.getCar();
      }
    });
  }

  getCar() {
    this.carService.getCar().subscribe((response) => {
      this.cars = response.data;
    });
  }
  getCarByBrand(brandId: number) {
    this.carService.getCarByBrand(brandId).subscribe((response) => {
      this.cars = response.data;
    });
  }
  getCarByColor(colorId: number) {
    this.carService.getCarByColor(colorId).subscribe((response) => {
      this.cars = response.data;
    });
  }
  getCarById(carId: number) {
    this.carService.getCarById(carId).subscribe((response) => {
      this.cars = response.data;
    });
  }
}
