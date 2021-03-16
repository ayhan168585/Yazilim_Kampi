import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { CarImaage } from '../models/carImage';
import { ListResponseModel } from '../models/listResponseModel';

@Injectable({
  providedIn: 'root'
})
export class CarImageService {

  apiUrl="https://localhost:44344/api/";
  constructor(private httpClient:HttpClient) { }

  getCarImages():Observable<ListResponseModel<CarImaage>>{
let newPath=this.apiUrl+"carimages/getall"
return this.httpClient.get<ListResponseModel<CarImaage>>(newPath)
  }

  getCarImagesById(carId:number):Observable<ListResponseModel<CarImaage>>{
    let newPath=this.apiUrl+"carimages/getbycarid?carid="+carId
    return this.httpClient.get<ListResponseModel<CarImaage>>(newPath)
  }
}
