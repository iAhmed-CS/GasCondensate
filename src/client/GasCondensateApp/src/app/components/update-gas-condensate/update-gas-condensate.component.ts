import { Component, Inject } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { GasCondensate } from 'src/app/models/gas-condensate.model';
import { GasCondensateService } from 'src/app/services/gas-condensate.service';
import {MAT_DIALOG_DATA} from '@angular/material/dialog';

@Component({
  selector: 'app-update-gas-condensate',
  templateUrl: './update-gas-condensate.component.html',
  styleUrls: ['./update-gas-condensate.component.css']
})
export class UpdateGasCondensateComponent {
  updateForm = new FormGroup({
    id: new FormControl(this.data.gasCondensate.id),
    fieldName: new FormControl(this.data.gasCondensate.fieldName),
    latitude: new FormControl(this.data.gasCondensate.latitude),
    longitude: new FormControl(this.data.gasCondensate.longitude),
    productionRate: new FormControl(this.data.gasCondensate.productionRate),
    cost: new FormControl(this.data.gasCondensate.cost),
    yearOfExtraction: new FormControl(this.data.gasCondensate.yearOfExtraction),
    maintenanceType: new FormControl(this.data.gasCondensate.maintenanceType),
  })
  
  constructor(private gasCondensateService: GasCondensateService,
    @Inject(MAT_DIALOG_DATA) public data: any) { }

  onSubmit() {
    const updatedGasCondensate: GasCondensate = {
      id: this.updateForm.value.id,
      fieldName: this.updateForm.value.name,
      latitude: this.updateForm.value.longitude,
      longitude: this.updateForm.value.longitude,
      productionRate: this.updateForm.value.productionRate,
      cost: this.updateForm.value.cost,
      yearOfExtraction: this.updateForm.value.yearOfExtraction,
      maintenanceType: this.updateForm.value.maintenanceType,
    }

    this.gasCondensateService.updateGasCondensate(updatedGasCondensate).subscribe();
  }
}
