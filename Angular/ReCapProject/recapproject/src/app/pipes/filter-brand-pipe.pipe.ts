import { Pipe, PipeTransform } from '@angular/core';
import { Car } from '../models/car';
import { CarDetailDto } from '../models/carDetailDto';

@Pipe({
  name: 'filterBrandPipe'
})
export class FilterBrandPipePipe implements PipeTransform {

  transform(value: CarDetailDto[], filterBrandText:string): CarDetailDto[] {
    filterBrandText=filterBrandText?filterBrandText.toLocaleLowerCase():""
    return filterBrandText?value.filter((c:CarDetailDto)=>c.brandName.toLocaleLowerCase().indexOf(filterBrandText)!==-1):value
  }

}
