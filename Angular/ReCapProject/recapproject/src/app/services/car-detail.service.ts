import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { CarDetailDto } from '../models/carDetailDto';
import { ListResponseModel } from '../models/listResponseModel';

@Injectable({
  providedIn: 'root'
})
export class CarDetailService {
  apiUrl="https://localhost:44344/api/";

  constructor(private httpClient:HttpClient) { }

  getCarDetail():Observable<ListResponseModel<CarDetailDto>>{
    let newPath=this.apiUrl+"cars/getcardetail"
    return this.httpClient.get<ListResponseModel<CarDetailDto>>(newPath)
  }

  getCarByBrand(brandId:number):Observable<ListResponseModel<CarDetailDto>>{
    let newPath=this.apiUrl+"cars/getcarsbybrand?id="+brandId
    return this.httpClient.get<ListResponseModel<CarDetailDto>>(newPath)
  }
  getCarByColor(colorId:number):Observable<ListResponseModel<CarDetailDto>>{
    let newPath=this.apiUrl+"cars/getcarsbycolor?id="+colorId
    return this.httpClient.get<ListResponseModel<CarDetailDto>>(newPath)
  }


  getByCarId(carId:number):Observable<ListResponseModel<CarDetailDto>>{
    let newPath=this.apiUrl+"cars/getcardetailbyid?carid="+carId
    return this.httpClient.get<ListResponseModel<CarDetailDto>>(newPath)
  }
}
