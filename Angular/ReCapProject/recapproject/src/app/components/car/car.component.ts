import { Component, OnInit } from '@angular/core';
import { CarDetailDto } from 'src/app/models/carDetailDto';
import { CarService } from 'src/app/services/cardetaildto.service';

@Component({
  selector: 'app-car',
  templateUrl: './car.component.html',
  styleUrls: ['./car.component.css']
})
export class CarComponent implements OnInit {

  carDetailDtos:CarDetailDto[]=[];

  constructor(private carService:CarService) { }

  ngOnInit(): void {
    this.getCar();
  }

  getCar(){
    this.carService.getCar().subscribe(response=>{
      this.carDetailDtos=response.data
    })
  }

}
