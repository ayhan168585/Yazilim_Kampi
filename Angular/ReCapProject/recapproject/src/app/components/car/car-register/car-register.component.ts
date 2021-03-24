import { Component, OnInit } from '@angular/core';
import { FormGroup,FormBuilder, Validators } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';
import { Brand } from 'src/app/models/brand';
import { Car } from 'src/app/models/car';
import { Color } from 'src/app/models/color';
import { BrandService } from 'src/app/services/brand.service';
import { CarService } from 'src/app/services/car.service';
import { ColorService } from 'src/app/services/color.service';

@Component({
  selector: 'app-car-register',
  templateUrl: './car-register.component.html',
  styleUrls: ['./car-register.component.css']
})
export class CarRegisterComponent implements OnInit {

  carAddForm:FormGroup;
  brands:Brand[]=[];
  cars:Car[]=[];
  colors:Color[]=[];

  constructor(
    private brandService:BrandService,
    private carService:CarService,
    private formBuilder:FormBuilder,
    private toastrService:ToastrService,
    private colorService:ColorService
    ) { }

  ngOnInit(): void {
    this.createCarAddForm()
    this.getBrands()
    this.getColor()


  }

  createCarAddForm(){
this.carAddForm=this.formBuilder.group({
  brandId:["",Validators.required],
  colorId:["",Validators.required],
  carName:["",Validators.required],
  modelYear:["",Validators.required],
  dailyPrice:["",Validators.required],
  description:["",Validators.required]

})
  }

  add(){
    if(this.carAddForm.valid){
     
      let carModel=Object.assign({},this.carAddForm.value)
      this.carService.add(carModel).subscribe(response=>{
       
        this.toastrService.success(response.message,"Başarılı")
      },responseError=>{
       if(responseError.error.Errors.length>0){

        for (let i = 0; i < responseError.error.Errors.length; i++) {
         
          this.toastrService.error(responseError.error.Errors[i].ErrorMessage,"Doğrulama hatası")
        }
      
       }
       
      })
    }
    else{
      this.toastrService.error("Formunuz eksik","Dikkat")
    }

  }
  getBrands() {
    this.brandService.getBrands().subscribe((response) => {
      this.brands = response.data;
    });
  }
  getColor(){
    this.colorService.getColor().subscribe(response=>{
      this.colors=response.data
    })
  }

}
