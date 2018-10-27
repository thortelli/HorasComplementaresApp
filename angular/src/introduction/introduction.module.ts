import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { JsonpModule } from '@angular/http';
import { HttpClientModule } from '@angular/common/http';

import { ModalModule } from 'ngx-bootstrap';

import { AbpModule } from '@abp/abp.module';

import { IntroductionRoutingModule } from './introduction-routing.module';

import { ServiceProxyModule } from '@shared/service-proxies/service-proxy.module';

import { SharedModule } from '@shared/shared.module';

import { TenantChangeComponent } from './tenant/tenant-change.component';
import { TenantChangeModalComponent } from './tenant/tenant-change-modal.component';
import { LoginComponent } from './login/login.component';
import { RegisterComponent } from './register/register.component';

import { IntroductionComponent } from './introduction.component';
import { TopBarIntroComponent } from './layout/topbar-intro.component';
import { FooterIntroComponent } from './layout/footer-intro.component';

import { LoginService } from './login/login.service';

@NgModule({
    imports: [
        CommonModule,
        FormsModule,
        HttpClientModule,
        JsonpModule,
        AbpModule,
        SharedModule,
        ServiceProxyModule,
        IntroductionRoutingModule,
        ModalModule.forRoot()
    ],
    declarations: [
        IntroductionComponent,
        TenantChangeComponent,
        TenantChangeModalComponent,
        LoginComponent,
        RegisterComponent,
        IntroductionComponent,
        TopBarIntroComponent,
        FooterIntroComponent
    ],
    providers: [
        LoginService
    ]
})
export class IntroductionModule {

}
