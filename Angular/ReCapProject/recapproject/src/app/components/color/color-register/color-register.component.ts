import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';
import { ColorService } from 'src/app/services/color.service';

@Component({
  selector: 'app-color-register',
  templateUrl: './color-register.component.html',
  styleUrls: ['./color-register.component.css'],
})
export class ColorRegisterComponent implements OnInit {

  colorAddForm : FormGroup;

  constructor(
    private formBuilder: FormBuilder,
    private colorService: ColorService,
    private toastrService: ToastrService
  ) {}

  ngOnInit(): void {
    this.createColorAddForm();
  }

 createColorAddForm(){
   this.colorAddForm=this.formBuilder.group({
     colorName:["",Validators.required],
   })

 }

 add(){
   if(this.colorAddForm.valid){
     let colorModel=Object.assign({},this.colorAddForm.value)
     this.colorService.add(colorModel).subscribe(response=>{
       this.toastrService.success(response.message,"Başarılı")
     })

   }
   else{
     this.toastrService.error("Formunuz eksik","Dikkat")
   }

 }
}
