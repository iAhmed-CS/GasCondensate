import { Component, OnInit, Output, EventEmitter } from '@angular/core';
import { Subscription } from 'rxjs';
import { Router } from '@angular/router';

@Component({
  selector: 'app-toolbar',
  templateUrl: './toolbar.component.html',
  styleUrls: ['./toolbar.component.css']
})
export class ToolbarComponent implements OnInit {
  title: string = 'Gas Condensate App';
  @Output() btnClick = new EventEmitter();
  subscription?: Subscription;

  constructor(public router: Router) {  }

  ngOnInit(): void {
  }

  onClick() {
    this.btnClick.emit();
  }
}