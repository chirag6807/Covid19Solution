import { prop,propObject,propArray,required,maxLength,range  } from "@rxweb/reactive-form-validators"
import { gridColumn } from "@rxweb/grid"


export class CaseInfoBase {

//#region id Prop
        @prop()
        id : number;
//#endregion id Prop


//#region name Prop
        @required()
        @maxLength({value:50})
        name : string;
//#endregion name Prop


//#region age Prop
        @range({minimumNumber:1,maximumNumber:2147483647})
        @required()
        age : number;
//#endregion age Prop


//#region gender Prop
        @required()
        @maxLength({value:50})
        gender : string;
//#endregion gender Prop


//#region address Prop
        @required()
        address : string;
//#endregion address Prop


//#region city Prop
        @required()
        @maxLength({value:50})
        city : string;
//#endregion city Prop


//#region country Prop
        @required()
        @maxLength({value:50})
        country : string;
//#endregion country Prop


//#region status Prop
        @required()
        @maxLength({value:50})
        status : string;
//#endregion status Prop

}