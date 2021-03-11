import { RentDetailDto } from "./rentDetailDto";
import { ResponseModel } from "./responseModel";

export interface RentDetailDtoResponseModel extends ResponseModel{
    data:RentDetailDto[]
}