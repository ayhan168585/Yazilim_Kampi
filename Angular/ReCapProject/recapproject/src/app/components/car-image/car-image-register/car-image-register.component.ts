import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup,FormControl, Validators } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';
import { Car } from 'src/app/models/car';
import { CarImage } from 'src/app/models/carImage';
import { CarDetailService } from 'src/app/services/car-detail.service';
import { CarImageService } from 'src/app/services/car-image.service';
import { CarService } from 'src/app/services/car.service';

@Component({
  selector: 'app-car-image-register',
  templateUrl: './car-image-register.component.html',
  styleUrls: ['./car-image-register.component.css'],
})
export class CarImageRegisterComponent implements OnInit {
  imageAddForm: FormGroup;
  images:CarImage[]=[];
  cars:Car[]=[];

  constructor(
    private formBuilder: FormBuilder,
    private carImageService: CarImageService,
    private toastrService:ToastrService,
    private carService:CarService

  ) {}

  ngOnInit(): void {

    this.getCar()
    this.createImageAddForm()
  }

  createImageAddForm(){
    this.imageAddForm=this.formBuilder.group({
      carId:["",Validators.required],
      imagePath:["",Validators.required],
      date:["",Validators.required]

      
    })
  }
  getCar() {
    this.carService.getCar().subscribe((response) => {
      this.cars = response.data;
    });
  }
 

  add(){
    if(this.imageAddForm.valid){
      let carImageModel=Object.assign({},this.imageAddForm.value)
      this.carImageService.add(carImageModel).subscribe(response=>{
        this.toastrService.success(response.message,"Başarılı")
      },responseError=>{
        if(responseError.error.Errors.length>0){
          for (let i = 0; i <responseError.error.Errors.length ; i++) {

            this.toastrService.error(responseError.error.Errors[i].ErrorMessage,"Doğrulama hatası")
          }
        }

      })

    }
    else{
      this.toastrService.error("Formunuz eksik","Dikkat")
    }

  }
}

