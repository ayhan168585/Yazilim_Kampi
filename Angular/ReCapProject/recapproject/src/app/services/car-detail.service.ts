import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { CarDetailDto } from '../models/carDetailDto';
import { CarImaage } from '../models/carImage';
import { ListResponseModel } from '../models/listResponseModel';

@Injectable({
  providedIn: 'root'
})
export class CarDetailService {
  apiUrl="https://localhost:44344/api/";

  constructor(private httpClient:HttpClient) { }
  getByCarId(carId:number):Observable<ListResponseModel<CarDetailDto>>{
    let newPath=this.apiUrl+"carimages/getbycarid?carid="+carId
    return this.httpClient.get<ListResponseModel<CarDetailDto>>(newPath)
  }
}
