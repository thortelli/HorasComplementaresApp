import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { LoginComponent } from './login/login.component';
import { RegisterComponent } from './register/register.component';
import { IntroductionComponent } from './introduction.component';

@NgModule({
    imports: [
        RouterModule.forChild([
            {
                path: '',
                component: IntroductionComponent,
                children: [
                    { path: 'login', component: LoginComponent },
                    { path: 'register', component: RegisterComponent }
                ]
            }
        ])
    ],
    exports: [
        RouterModule
    ]
})
export class IntroductionRoutingModule {}
