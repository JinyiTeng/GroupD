import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AddProductLossComponent } from './add-product-loss.component';

describe('AddProductLossComponent', () => {
  let component: AddProductLossComponent;
  let fixture: ComponentFixture<AddProductLossComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AddProductLossComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(AddProductLossComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
