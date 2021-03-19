import { Pipe, PipeTransform } from '@angular/core';
import { Car } from '../models/car';

@Pipe({
  name: 'filterBrandPipe'
})
export class FilterBrandPipePipe implements PipeTransform {

  transform(value: Car[], filterBrandText:string): Car[] {
    filterBrandText=filterBrandText?filterBrandText.toLocaleLowerCase():""
    return filterBrandText?value.filter((c:Car)=>c.brandName.toLocaleLowerCase().indexOf(filterBrandText)!==-1):value
  }

}
