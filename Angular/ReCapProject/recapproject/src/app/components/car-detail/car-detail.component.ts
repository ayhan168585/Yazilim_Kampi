import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Car } from 'src/app/models/car';
import { CarImaage } from 'src/app/models/carImage';
import { CarImageService } from 'src/app/services/car-image.service';
import { CarService } from 'src/app/services/car.service';

@Component({
  selector: 'app-car-detail',
  templateUrl: './car-detail.component.html',
  styleUrls: ['./car-detail.component.css']
})
export class CarDetailComponent implements OnInit {
  cars:Car[]=[];
  carimages:CarImaage[]=[];
  imagePaths:string[]=[];
  imageUrl="http://localhost:4200/WebAPI/Images/Cars/";

  constructor(private carService:CarService,private activatedRoute:ActivatedRoute,private carImageService:CarImageService) { }

  ngOnInit(): void {this.activatedRoute.params.subscribe(params=>{
    if(params["carId"]){
      this.getCarById(params["carId"])
    }
    else{
      this.getCar()
    }
  })
    

      }
  
  getCar(){
    this.carService.getCar().subscribe(response=>{
      this.cars=response.data
    })
  }
  getCarImages(){
    this.carImageService.getCarImages().subscribe(response=>{
      this.carimages=response.data
    })

  }
  getCarImagesById(carId:number){
    this.carImageService.getCarImagesById(carId).subscribe(response=>{
      this.carimages=response.data
    })
  }
  getCarById(carId:number){
    this.carService.getCarById(carId).subscribe(response=>{
      this.cars=response.data
    })
  }

}
