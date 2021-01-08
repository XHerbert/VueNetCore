<!--
*Author：jxx
 *Contact：283591387@qq.com
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *业务请在@/extension/effective/MainModel.js此处编写
 -->
<template>
    <div>
        <view-grid
                   ref="grid"
                   :columns="columns"
                   :detail="detail"
                   :editFormFields="editFormFields"
                   :editFormFileds="editFormFields"
                   :editFormOptions="editFormOptions"
                   :searchFormFields="searchFormFields"
                   :searchFormFileds="searchFormFields"
                   :searchFormOptions="searchFormOptions"
                   :table="table"
                   :extend="extend">
        </view-grid>
    </div>
</template>

<script>
    import extend from "@/extension/effective/MainModel.js";
    import ViewGrid from "@/components/basic/ViewGrid.vue";
    var vueParam = {
        components: {
            ViewGrid
        },
        data() {
            return {
                table: {
                    key: 'MAIN_ID',
                    footer: "Foots",
                    cnName: '子场景',
                    name: 'MainModel',
                    url: "/MainModel/",
                    sortName: "MAIN_ID"
                },
                extend: extend,
                editFormFields: {"MODEL_ID":"","PROJECT_ID":"","REFER_KEY":"","DESCRIPTION":"","MODEL_TYPE":"","FLOOR":"","BORDER_ENABLE":"","SHADOW_ENABLE":"","ENABLE_FLAG":"","EFFECTIVE_TYPE":"","CAMERA":""},
                editFormOptions: [[{"title":"模型","field":"MODEL_ID","type":"text"},
                               {"dataKey":"project","data":[],"title":"项目","required":true,"field":"PROJECT_ID","type":"select"},
                               {"title":"页面菜单","required":true,"field":"REFER_KEY","type":"text"}],
                              [{"dataKey":"modelType","data":[],"title":"模型类型","field":"MODEL_TYPE","type":"select"},
                               {"title":"子场景描述","field":"DESCRIPTION","type":"text"},
                               {"dataKey":"floor","data":[],"title":"楼层","field":"FLOOR","type":"select"}],
                              [{"dataKey":"activeFlag","data":[],"title":"轮廓线","field":"BORDER_ENABLE","type":"switch"},
                               {"dataKey":"activeFlag","data":[],"title":"阴影","field":"SHADOW_ENABLE","type":"switch"},
                               {"dataKey":"enable","data":[],"title":"有效标识","field":"ENABLE_FLAG","type":"switch"}],
                              [{"dataKey":"effectRange","data":[],"title":"效果范围","field":"EFFECTIVE_TYPE","type":"select"},
                               {"title":"相机位","field":"CAMERA"}]],
                searchFormFields: {"MODEL_ID":"","PROJECT_ID":"","REFER_KEY":"","MODEL_TYPE":""},
                searchFormOptions: [[{"title":"模型","field":"MODEL_ID","type":"text"},{"dataKey":"project","data":[],"title":"项目","field":"PROJECT_ID","type":"select"},{"dataKey":"modelType","data":[],"title":"模型类型","field":"MODEL_TYPE","type":"select"},{"title":"页面菜单","field":"REFER_KEY","type":"text"}]],
                columns: [{field:'MODEL_ID',title:'模型',type:'string',width:150,align:'left',sortable:true},
                       {field:'PROJECT_ID',title:'项目',type:'int',bind:{ key:'project',data:[]},width:100,require:true,align:'left'},
                       {field:'REFER_KEY',title:'页面菜单',type:'string',width:120,require:true,align:'left'},
                       {field:'DESCRIPTION',title:'子场景描述',type:'string',link:true,width:220,align:'left'},
                       {field:'MODEL_TYPE',title:'模型类型',type:'string',bind:{ key:'modelType',data:[]},width:90,align:'left'},
                       {field:'FLOOR',title:'楼层',type:'string',bind:{ key:'floor',data:[]},width:70,align:'left'},
                       {field:'EFFECTIVE_TYPE',title:'效果范围',type:'short',bind:{ key:'effectRange',data:[]},width:90,align:'left'},
                       {field:'BORDER_ENABLE',title:'轮廓线',type:'short',bind:{ key:'activeFlag',data:[]},width:90,align:'left'},
                       {field:'SHADOW_ENABLE',title:'阴影',type:'short',bind:{ key:'activeFlag',data:[]},width:90,align:'left'},
                       {field:'ENABLE_FLAG',title:'有效标识',type:'short',bind:{ key:'enable',data:[]},width:90,align:'left'},
                       {field:'CAMERA',title:'相机位',type:'string',width:90,align:'left'}],
                detail: {
                    cnName:"行为列表",
                    columns: [{field:'ACTION',title:'动作类',type:'short',bind:{ key:'actionBehavior',data:[]},width:90,edit:{type:'select'},align:'left',sortable:true},
                       {field:'ACTION_VALUE',title:'动作值',type:'string',width:220,edit:{type:''},align:'left'},
                       {field:'DESCRIPTION',title:'效果描述',type:'string',link:true,width:220,edit:{type:'text'},align:'left'},
                       {field:'EFFECT_KEY',title:'BIM方法',type:'string',width:220,edit:{type:'text'},align:'left'},
                       {field:'EFFECT_VALUE',title:'行为取值',type:'string',bind:{ key:'actionBehavior',data:[]},width:90,edit:{type:'select'},align:'left'},
                       {field:'ENABLE_FLAG',title:'有效标识',type:'short',width:90,align:'left'},
                       {field:'ORDER',title:'效果排序',type:'short',width:90,edit:{type:'number'},align:'left'},
                       {field:'TARGET_MODEL',title:'目标模型',type:'string',width:90,edit:{type:'text'},align:'left'}],
                    sortName: "ID",
                    key:"ID"
                }
            };
        }
    };
    export default vueParam;
</script>
