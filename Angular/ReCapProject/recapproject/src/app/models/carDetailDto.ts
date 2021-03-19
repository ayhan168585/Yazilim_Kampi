import { Car } from "./car";
import { CarImage } from "./carImage";

export interface CarDetailDto{
   carId:number;
   brandId:number;
   colorId:number;
   brandName:string;
   colorName:string;
   carName:string;
   modelYear:number;
   dailyPrice:number;
   imagePath:string;
   description:string;
    
}