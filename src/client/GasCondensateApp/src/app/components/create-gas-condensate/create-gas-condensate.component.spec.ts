import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CreateGasCondensateComponent } from './create-gas-condensate.component';

describe('CreateGasCondensateComponent', () => {
  let component: CreateGasCondensateComponent;
  let fixture: ComponentFixture<CreateGasCondensateComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [CreateGasCondensateComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(CreateGasCondensateComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
