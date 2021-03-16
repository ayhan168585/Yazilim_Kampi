import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { RentDetailDto } from 'src/app/models/rentDetailDto';
import { RentalService } from 'src/app/services/rental.service';

@Component({
  selector: 'app-rental',
  templateUrl: './rental.component.html',
  styleUrls: ['./rental.component.css']
})
export class RentalComponent implements OnInit {

  rentals:RentDetailDto[]=[];

  constructor(private rentalService:RentalService,private activatedRoute:ActivatedRoute) { }

  ngOnInit(): void {this.activatedRoute.params.subscribe(params=>{
    if(params["userId"]){
      this.getByCustomer(params["userId"])
    }
    else{
      this.getRental();
    }
  })
    
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

}
