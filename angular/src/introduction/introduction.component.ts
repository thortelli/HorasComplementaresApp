import { Component, ViewContainerRef, OnInit, ViewEncapsulation, Injector } from '@angular/core';
import { LoginService } from './login/login.service';
import { AppComponentBase } from '@shared/app-component-base';

@Component({
    templateUrl: './introduction.component.html',
    styleUrls: [
        './introduction.component.css'
    ],
    encapsulation: ViewEncapsulation.None
})
export class IntroductionComponent extends AppComponentBase implements OnInit {

    private viewContainerRef: ViewContainerRef;

    versionText: string;
    currentYear: number;

    public constructor(
        injector: Injector,
        private _loginService: LoginService
    ) {
        super(injector);

        this.currentYear = new Date().getFullYear();
        this.versionText = this.appSession.application.version + ' [' + this.appSession.application.releaseDate.format('YYYYDDMM') + ']';
    }

    ngOnInit(): void {
        /* $('body').attr('class', 'login-page'); */
    }
}
