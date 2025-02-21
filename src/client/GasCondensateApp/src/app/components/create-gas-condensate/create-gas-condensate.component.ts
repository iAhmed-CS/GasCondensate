import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { GasCondensate } from 'src/app/models/gas-condensate.model';
import { GasCondensateService } from 'src/app/services/gas-condensate.service';

@Component({
  selector: 'create-gas-condensate',
  templateUrl: './create-gas-condensate.component.html',
  styleUrls: ['./create-gas-condensate.component.css']
})
export class CreateGasCondensateComponent {
  addForm = new FormGroup({
    id: new FormControl(""),
    fieldName: new FormControl(""),
    latitude: new FormControl(""),
    longitude: new FormControl(""),
    productionRate: new FormControl(""),
    cost: new FormControl(""),
    yearOfExtraction: new FormControl(""),
    maintenanceType: new FormControl(""),
  })

  constructor(private gasCondensateService: GasCondensateService) {  }

  addData() {
    const gasCondensate: GasCondensate = {
      id: this.addForm.value.id,
      fieldName: this.addForm.value.fieldName,
      latitude: this.addForm.value.longitude,
      longitude: this.addForm.value.longitude,
      productionRate: this.addForm.value.productionRate,
      cost: this.addForm.value.cost,
      yearOfExtraction: this.addForm.value.yearOfExtraction,
      maintenanceType: this.addForm.value.maintenanceType,
    }

    this.gasCondensateService.addGasCondensate(gasCondensate).subscribe();
  }
}
