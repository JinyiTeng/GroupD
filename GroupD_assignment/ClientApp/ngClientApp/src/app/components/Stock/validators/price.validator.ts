import { FormControl } from '@angular/forms';

export class PriceValidator {

  static validPrice(fc: FormControl){

    if(fc.value.toString().split(".").length > 1 && fc.value.toString().split(".")[1].length > 2){
      return {
        validPrice: true
      };
    } else {
      return null;
    }
  }
}
