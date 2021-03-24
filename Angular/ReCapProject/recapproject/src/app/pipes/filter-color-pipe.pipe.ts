import { Pipe, PipeTransform } from '@angular/core';
import { Car } from '../models/car';
import { CarDetailDto } from '../models/carDetailDto';

@Pipe({
  name: 'filterColorPipe'
})
export class FilterColorPipePipe implements PipeTransform {

  transform(value: CarDetailDto[], filterColorText:string): CarDetailDto[] {
    filterColorText=filterColorText?filterColorText.toLocaleLowerCase():""
    return filterColorText?value.filter((c:CarDetailDto)=>c.colorName.toLocaleLowerCase().indexOf(filterColorText)!==-1):value;
  }

}
