import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { ListResponseModel } from '../models/listResponseModel';
import { RentDetailDto } from '../models/rentDetailDto';

@Injectable({
  providedIn: 'root'
})
export class RentalService {

  apiUrl="https://localhost:44344/api/";

  constructor(private httpClient:HttpClient) { }

  getRental():Observable<ListResponseModel<RentDetailDto>>{
    let newPath=this.apiUrl+"rentals/getrentaldetail"
    return this.httpClient.get<ListResponseModel<RentDetailDto>>(newPath)
  }
  GetByCustomer(userId:number):Observable<ListResponseModel<RentDetailDto>>{
    let newPath=this.apiUrl+"rentals/getbycustomer?userId="+userId
    return this.httpClient.get<ListResponseModel<RentDetailDto>>(newPath)
  }

}
