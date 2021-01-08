<!--
*Author：jxx
 *Contact：283591387@qq.com
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *业务请在@/extension/project/ProjectList.js此处编写
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
    import extend from "@/extension/project/ProjectList.js";
    import ViewGrid from "@/components/basic/ViewGrid.vue";
    var vueParam = {
        components: {
            ViewGrid
        },
        data() {
            return {
                table: {
                    key: 'ID',
                    footer: "Foots",
                    cnName: '项目列表',
                    name: 'ProjectList',
                    url: "/ProjectList/",
                    sortName: "ID"
                },
                extend: extend,
                editFormFields: {},
                editFormOptions: [],
                searchFormFields: {"START_TIME":"","END_TIME":"","PROJECT_CODE":""},
                searchFormOptions: [[{"title":"项目编码","field":"PROJECT_CODE","type":"text"}],[{"title":"开始时间","field":"START_TIME","type":"datetime"},{"title":"结束时间","field":"END_TIME","type":"datetime"}]],
                columns: [{field:'NAME',title:'项目名称',type:'string',width:90,align:'left',sortable:true},
                       {field:'CODE',title:'编码',type:'string',width:90,align:'left'},
                       {field:'BIM_FLAG',title:'BIM项目',type:'int',width:90,align:'left'},
                       {field:'START_TIME',title:'开始时间',type:'datetime',width:90,align:'left',sortable:true},
                       {field:'END_TIME',title:'结束时间',type:'datetime',width:90,align:'left',sortable:true},
                       {field:'LAT',title:'经度',type:'int',width:90,align:'left'},
                       {field:'LNG',title:'纬度',type:'int',width:90,align:'left'},
                       {field:'STATUS',title:'状态',type:'int',width:90,align:'left'},
                       {field:'TPL_ID',title:'模板',type:'int',width:90,hidden:true,readonly:true,align:'left'},
                       {field:'PROJECT_CODE',title:'项目编码',type:'string',width:90,align:'left'},
                       {field:'ADDRESS',title:'地址',type:'string',width:90,align:'left'}],
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
