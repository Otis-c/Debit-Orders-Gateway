/* tslint:disable:no-unused-variable */

import { TestBed, async, inject } from '@angular/core/testing';
import { DebitOrdersService } from './debit-orders.service';

describe('Service: DebitOrders', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [DebitOrdersService]
    });
  });

  it('should ...', inject([DebitOrdersService], (service: DebitOrdersService) => {
    expect(service).toBeTruthy();
  }));
});
