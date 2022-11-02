import { FormControl } from '@angular/forms';

export class AmountValidator {

  static validAmount(fc: FormControl){

    if((fc.value + '').indexOf('.') != -1){
      return {
        validAmount: true
      };
    } else {
      return null;
    }
  }
}
