<!--
*Author：jxx
 *Contact：283591387@qq.com
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *业务请在@/extension/order/MainModel.js此处编写
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
    import extend from "@/extension/order/MainModel.js";
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
                    cnName: '场景配置',
                    name: 'MainModel',
                    url: "/MainModel/",
                    sortName: "MAIN_ID"
                },
                extend: extend,
                editFormFields: {"MODEL_ID":"","MODEL_TYPE":"","SYSTEM_CODE":"","PROJECT_ID":"","FLOOR":"","BORDER_ENABLE":"","SHADOW_ENABLE":"","CAMERA":"","DESCRIPTION":""},
                editFormOptions: [[{"dataKey":"modelType","data":[],"title":"模型类型","field":"MODEL_TYPE","type":"select"},
                               {"title":"系统编码","field":"SYSTEM_CODE","type":"text"},
                               {"title":"模型","field":"MODEL_ID","type":"text"}],
                              [{"dataKey":"floor","data":[],"title":"楼层","field":"FLOOR","type":"select"},
                               {"dataKey":"pin","data":[],"title":"项目","required":true,"field":"PROJECT_ID","type":"select"},
                               {"title":"启用轮廓","field":"BORDER_ENABLE","type":"switch"},
                               {"title":"启用阴影","field":"SHADOW_ENABLE","type":"switch"}],
                              [{"title":"相机位","field":"CAMERA","type":"textarea"},
                               {"title":"描述","field":"DESCRIPTION","type":"textarea"}]],
                searchFormFields: {"PROJECT_ID":"","MODEL_ID":"","MODEL_TYPE":"","FLOOR":"","SYSTEM_CODE":"","BORDER_ENABLE":"","SHADOW_ENABLE":""},
                searchFormOptions: [[{"dataKey":"pin","data":[],"title":"项目","field":"PROJECT_ID","type":"select"},{"title":"模型","field":"MODEL_ID","type":"text"},{"title":"系统编码","field":"SYSTEM_CODE","type":"text"},{"dataKey":"modelType","data":[],"title":"模型类型","field":"MODEL_TYPE","type":"select"}],[{"dataKey":"floor","data":[],"title":"楼层","field":"FLOOR","type":"select"},{"title":"启用轮廓","field":"BORDER_ENABLE","type":"switch"},{"title":"启用阴影","field":"SHADOW_ENABLE","type":"switch"}]],
                columns: [{field:'PROJECT_ID',title:'项目',type:'int',bind:{ key:'pin',data:[]},width:90,require:true,align:'left',sortable:true},
                       {field:'MODEL_ID',title:'模型',type:'string',width:220,align:'left'},
                       {field:'Enable',title:'是否有效',type:'int',bind:{ key:'enable',data:[]},width:90,hidden:true,align:'left'},
                       {field:'MODEL_TYPE',title:'模型类型',type:'string',bind:{ key:'modelType',data:[]},width:220,align:'left'},
                       {field:'FLOOR',title:'楼层',type:'string',bind:{ key:'floor',data:[]},width:90,align:'left'},
                       {field:'SYSTEM_CODE',title:'系统编码',type:'string',width:90,align:'left'},
                       {field:'EFFECTIVE_TYPE',title:'类型',type:'int',width:90,align:'left'},
                       {field:'BORDER_ENABLE',title:'启用轮廓',type:'int',width:90,align:'left'},
                       {field:'SHADOW_ENABLE',title:'启用阴影',type:'int',width:90,align:'left'},
                       {field:'CAMERA',title:'相机位',type:'string',width:220,align:'left'},
                       {field:'GUID',title:'Guid',type:'string',width:90,hidden:true,readonly:true,align:'left'},
                       {field:'DESCRIPTION',title:'描述',type:'string',width:220,align:'left'},
                       {field:'MAIN_ID',title:'MAIN_ID',type:'int',width:80,hidden:true,readonly:true,require:true,align:'left'},
                       {field:'CREATE_STAFF_ID',title:'CREATE_STAFF_ID',type:'int',width:80,align:'left'},
                       {field:'CREATE_TIME',title:'CREATE_TIME',type:'datetime',width:150,align:'left',sortable:true},
                       {field:'MODIFY_STAFF_ID',title:'MODIFY_STAFF_ID',type:'int',width:80,align:'left'},
                       {field:'MODIFY_TIME',title:'MODIFY_TIME',type:'datetime',width:150,align:'left',sortable:true}],
                detail: {
                    cnName:"#detailCnName",
                    columns: [],
                    sortName: "",
                    key:""
                }
            };
        }
    };
    export default vueParam;
</script>
