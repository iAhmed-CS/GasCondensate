import { Component, OnInit, Input, Output, EventEmitter, inject } from '@angular/core';
import { GasCondensate } from 'src/app/models/gas-condensate.model';
import { GasCondensateService } from 'src/app/services/gas-condensate.service';
import {MatDialog} from '@angular/material/dialog';
import { UpdateGasCondensateComponent } from '../update-gas-condensate/update-gas-condensate.component';
import { CreateGasCondensateComponent } from '../create-gas-condensate/create-gas-condensate.component';


@Component({
  selector: 'display-gas-condensate',
  templateUrl: './display-gas-condensate.component.html',
  styleUrls: ['./display-gas-condensate.component.css']
})
export class DisplayGasCondensateComponent implements OnInit {
  gasCondensateList: GasCondensate[] = [];
  displayedColumns: string[] = ['fieldName', 'latitude', 'longitude', 'productionRate', 'cost', 'yearOfExtraction', 'maintenanceType', 'actions'];

  constructor(private gasCondensateService: GasCondensateService, private dialog: MatDialog) { }

  ngOnInit(): void {
    this.gasCondensateService.getGasCondensateList().subscribe((x) => this.gasCondensateList = x.gasCondensateList);
  }

  openEditDialog(gasCondensate: GasCondensate) {
    const dialogRef = this.dialog.open(UpdateGasCondensateComponent, {
      data: {
        gasCondensate: gasCondensate,
      },
  });

    dialogRef.afterClosed().subscribe(() => {
      this.gasCondensateService.getGasCondensateList().subscribe((x) => this.gasCondensateList = x.gasCondensateList);
    });
  }

  openAddDialog() {
    const dialogRef = this.dialog.open(CreateGasCondensateComponent);

    dialogRef.afterClosed().subscribe(() => {
      this.gasCondensateService.getGasCondensateList().subscribe((x) => this.gasCondensateList = x.gasCondensateList);
    });
  }


  deleteData(id: string) {
    this.gasCondensateService.deleteGasCondensate(id).subscribe(() => {
      this.gasCondensateService.getGasCondensateList().subscribe((x) => this.gasCondensateList = x.gasCondensateList);
    });
  }
}
