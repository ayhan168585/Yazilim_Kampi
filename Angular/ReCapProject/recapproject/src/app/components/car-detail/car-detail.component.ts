import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Car } from 'src/app/models/car';
import { CarDetailDto } from 'src/app/models/carDetailDto';
import { CarImage } from 'src/app/models/carImage';
import { CarDetailService } from 'src/app/services/car-detail.service';
import { CarImageService } from 'src/app/services/car-image.service';

@Component({
  selector: 'app-car-detail',
  templateUrl: './car-detail.component.html',
  styleUrls: ['./car-detail.component.css']
})
export class CarDetailComponent implements OnInit {
  cars:CarDetailDto[]=[];
  carimages:CarImage[]=[];
  imagePaths:string[]=[];
  imageUrl="http://localhost:4200/WebAPI/Images/Cars/";

  constructor(private carService:CarDetailService,private activatedRoute:ActivatedRoute,private carImageService:CarImageService) { }

  ngOnInit(): void {this.activatedRoute.params.subscribe(params=>{
    if(params["carId"]){
      this.getByCarId(params["carId"]);
    }
    else{
      this.getCarDetail();
    }
  })
    

      }
  
  //  getCar(){
  //    this.carService.getCar().subscribe(response=>{
  //      this.cars=response.data
  //    })
  //  }
  //  getCarImages(){
  //    this.carImageService.getCarImages().subscribe(response=>{
  //      this.carimages=response.data
  //    })

  //  }
  //  getCarImagesById(carId:number){
  //    this.carImageService.getCarImagesById(carId).subscribe(response=>{
  //      this.carimages=response.data
  //    })
  //  }
  getCarDetail(){
    this.carService.getCarDetail().subscribe(response=>{
      this.cars=response.data
    })
  }
  getByCarId(carId:number){
    this.carService.getByCarId(carId).subscribe(response=>{
      this.cars=response.data
    })
  }
  addToRent(car:CarDetailDto){

    console.log(car)
  }

}
