import { Pipe, PipeTransform } from '@angular/core';
import { Car } from '../models/car';

@Pipe({
  name: 'filterColorPipe'
})
export class FilterColorPipePipe implements PipeTransform {

  transform(value: Car[], filterColorText:string): Car[] {
    filterColorText=filterColorText?filterColorText.toLocaleLowerCase():""
    return filterColorText?value.filter((c:Car)=>c.brandName.toLocaleLowerCase().indexOf(filterColorText)!==-1):value
  }

}
