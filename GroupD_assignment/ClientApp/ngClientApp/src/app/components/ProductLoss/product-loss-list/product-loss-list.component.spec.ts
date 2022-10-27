import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ProductLossListComponent } from './product-loss-list.component';

describe('ProductLossListComponent', () => {
  let component: ProductLossListComponent;
  let fixture: ComponentFixture<ProductLossListComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ProductLossListComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ProductLossListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
