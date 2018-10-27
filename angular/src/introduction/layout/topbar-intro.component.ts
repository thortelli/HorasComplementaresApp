import { Component, Injector, ViewEncapsulation } from '@angular/core';
import { AppComponentBase } from '@shared/app-component-base';

@Component({
    selector: 'app-top-bar',
    templateUrl: './topbar-intro.component.html',
    styleUrls: ['./topbar-intro.component.css'],
    encapsulation: ViewEncapsulation.None
})
export class TopBarIntroComponent extends AppComponentBase {

    constructor(
        injector: Injector
    ) {
        super(injector);
    }
}
