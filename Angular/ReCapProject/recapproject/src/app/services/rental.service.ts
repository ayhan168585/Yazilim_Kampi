import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { RentDetailDtoResponseModel } from '../models/rentDetailDtoResponseModel';

@Injectable({
  providedIn: 'root'
})
export class RentalService {

  apiUrl="https://localhost:44344/api/rentals/getrentaldetail";

  constructor(private httpClient:HttpClient) { }

  getRental():Observable<RentDetailDtoResponseModel>{
    return this.httpClient.get<RentDetailDtoResponseModel>(this.apiUrl)
  }
}
