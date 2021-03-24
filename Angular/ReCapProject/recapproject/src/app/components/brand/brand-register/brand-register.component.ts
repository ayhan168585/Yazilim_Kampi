import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';
import { BrandService } from 'src/app/services/brand.service';
@Component({
  selector: 'app-brand-register',
  templateUrl: './brand-register.component.html',
  styleUrls: ['./brand-register.component.css'],
})
export class BrandRegisterComponent implements OnInit {
  brandAddForm: FormGroup;

  constructor(
    private formBuilder: FormBuilder,
    private brandService: BrandService,
    private toastrService:ToastrService
  ) {}

  ngOnInit(): void {
    this.createBrandAddForm();
  }
  createBrandAddForm() {
    this.brandAddForm = this.formBuilder.group({
      brandName: ['', Validators.required],
    });
  }
  add() {
    if (this.brandAddForm.valid) {
      let brandModel = Object.assign({}, this.brandAddForm.value);
      this.brandService.add(brandModel).subscribe(response=>{
       
        this.toastrService.success(response.message,"Başarılı")
      })
     
    }
    else{
      this.toastrService.error("Formunuz Eksik","Dikkat")
    }
  }
}
