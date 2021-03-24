import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Brand } from 'src/app/models/brand';
import { Car } from 'src/app/models/car';
import { CarDetailDto } from 'src/app/models/carDetailDto';
import { BrandService } from 'src/app/services/brand.service';
import { CarDetailService } from 'src/app/services/car-detail.service';
import { CarService } from 'src/app/services/car.service';

@Component({
  selector: 'app-car',
  templateUrl: './car.component.html',
  styleUrls: ['./car.component.css'],
})
export class CarComponent implements OnInit {
  cars: Car[] = [];
  cardetaildtos:CarDetailDto[]=[];
  brands:Brand[]=[];
  filterText="";
  filterBrandText="";
  filterColorText:"";

  constructor(
    private carService: CarService,
    private CarDetailService:CarDetailService,
    private brandService:BrandService,
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
        this.getCarDetail();
        this.getBrands();
      }
    });
  }

  getCar() {
    this.carService.getCar().subscribe((response) => {
      this.cars = response.data;
    });
  }
  getCarDetail() {
    this.CarDetailService.getCarDetail().subscribe((response) => {
      this.cardetaildtos = response.data;
    });
  }
  getCarByBrand(brandId: number) {
    this.CarDetailService.getCarByBrand(brandId).subscribe((response) => {
      this.cardetaildtos = response.data;
    });
  }
  getCarByColor(colorId: number) {
    this.CarDetailService.getCarByColor(colorId).subscribe((response) => {
      this.cardetaildtos = response.data;
    });
  }
  getCarById(carId: number) {
    this.carService.getCarById(carId).subscribe((response) => {
      this.cars = response.data;
    });
  }
  getBrands() {
    this.brandService.getBrands().subscribe((response) => {
      this.brands = response.data;
    });
  }
}
