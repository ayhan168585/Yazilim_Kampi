import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Car } from '../models/car';
import { ListResponseModel } from '../models/listResponseModel';

@Injectable({
  providedIn: 'root'
})
export class CarService {

  apiUrl="https://localhost:44344/api/";
  

  constructor(private httpClient:HttpClient) { }

  getCar():Observable<ListResponseModel<Car>>{
    let newPath=this.apiUrl+"cars/getall"
    return this.httpClient.get<ListResponseModel<Car>>(newPath)
  }

  getCarByBrand(brandId:number):Observable<ListResponseModel<Car>>{
    let newPath=this.apiUrl+"cars/getcarsbybrand?id="+brandId
    return this.httpClient.get<ListResponseModel<Car>>(newPath)
  }
  getCarByColor(colorId:number):Observable<ListResponseModel<Car>>{
    let newPath=this.apiUrl+"cars/getcarsbycolor?id="+colorId
    return this.httpClient.get<ListResponseModel<Car>>(newPath)
  }
  getCarById(carId:number):Observable<ListResponseModel<Car>>{
    let newPath=this.apiUrl+"cars/getbyid?id="+carId
    return this.httpClient.get<ListResponseModel<Car>>(newPath)
  }
 
 
}
