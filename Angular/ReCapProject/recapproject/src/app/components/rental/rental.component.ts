import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Car } from 'src/app/models/car';
import { RentDetailDto } from 'src/app/models/rentDetailDto';
import { CarService } from 'src/app/services/car.service';
import { RentalService } from 'src/app/services/rental.service';

@Component({
  selector: 'app-rental',
  templateUrl: './rental.component.html',
  styleUrls: ['./rental.component.css']
})
export class RentalComponent implements OnInit {

  rentals:RentDetailDto[]=[];
  cars:Car[]=[];
  carFilter:number;

  constructor(private rentalService:RentalService,private activatedRoute:ActivatedRoute,private carService:CarService) { }

  ngOnInit(): void {this.activatedRoute.params.subscribe(params=>{
    if(params["customerId"]){
      this.getByCustomer(params["customerId"])
    }
    else{
      this.getRental();
      this.getCar();
    }
  })
    
  }
  getCar() {
    this.carService.getCar().subscribe((response) => {
      this.cars = response.data;
    });
  }
  getRental(){
    this.rentalService.getRental().subscribe(response=>{
      this.rentals=response.data
    })
  }
  getByCustomer(userId:number){
    this.rentalService.GetByCustomer(userId).subscribe(response=>{
      this.rentals=response.data
    })
  }
  getSelectedCar(carId: Number) {
    if (this.carFilter == carId)
      return true;
    else
      return false;
  }
}
//   getSelectedColor(colorId: Number) {
//     if (this.colorFilter == colorId)
//       return true;
//     else
//       return false

// }
