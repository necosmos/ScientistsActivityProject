import React, {useState} from 'react';
import styles from './home.module.scss';
import {
    Grid,
    Paper,
    Switch,
    Table,
    TableBody,
    TableCell,
    TableContainer,
    TableHead,
    TableRow,
    TextField
} from "@mui/material";
import SendIcon from '@mui/icons-material/Send';
import LoadingButton from '@mui/lab/LoadingButton';
import {DemoContainer} from '@mui/x-date-pickers/internals/demo';
import {LocalizationProvider} from '@mui/x-date-pickers/LocalizationProvider';
import {AdapterDayjs} from '@mui/x-date-pickers/AdapterDayjs';
import {DateField} from '@mui/x-date-pickers/DateField';

export const Home = () => {
    const [range, setRange] = useState(false);
    const [loading, setLoading] = useState(false);
    const [name, setName] = useState(null);
    const [themes, setThemes] = useState(null);
    const [keyWords, setKeyWords] = useState(null);
    const [date, setDate] = useState(null);
    const [from, setFrom] = useState(null);
    const [to, setTo] = useState(null);

    const [result, setResult] = useState(null);
    const [statistic, setStatistic] = useState(null);

    const handleClick = () => {
        setLoading(true);

        const task = {
            name: name ? name : null,
            themes: themes ? themes : null,
            keyWordsArray: keyWords ? keyWords.split(', ') : null,
            date: date ? date : null,
            from: from ? from : null,
            to: to ? to : null
        };

        fetch('http://localhost:5273/api/search', {
            method: 'POST',
            headers: {'Content-Type': 'application/json'},
            body: JSON.stringify(task)
        }).then(res => res.json())
            .then(res => {
                setResult(res.response);
                setStatistic(res['statistic'])
                setLoading(false);
            })
            .catch(err => {
                console.log(err);
                setLoading(false);
            });
    }

    return (
        <div className={styles.wrapper}>
            <div className={styles.titleWrap}>
                <div className={styles.title}>Вітаємо на нашому сайті !</div>
                <div className={styles.subTitle}>Тут ви можете знайти інформацію про наукові статті</div>
            </div>
            <div className={styles.content}>
                <Grid container spacing={2}>
                    <Grid item xs={6}>
                        <TextField label={'Пошук за ПІБ'} fullWidth value={name || ''}
                                   onChange={e => setName(e.target.value)}/>
                    </Grid>
                    <Grid item xs={6}>
                        <TextField label={'Пошук за темами'} fullWidth value={themes || ''}
                                   onChange={e => setThemes(e.target.value)}/>
                    </Grid>
                    <Grid item xs={12}>
                        <TextField label={'Пошук за ключовими словами(через кому з пробілом)'} fullWidth
                                   value={keyWords || ''}
                                   onChange={e => setKeyWords(e.target.value)}/>
                    </Grid>
                    <Grid item xs={12} align={'center'} alignItems={'center'} justifyContent={'center'}
                          sx={{display: 'flex', gap: 2}}>
                        <div className={styles.label}>Пошук за датою</div>
                        <Switch checked={range} onChange={() => setRange(!range)}/>
                        <div className={styles.label} style={{left: '54%'}}>Пошук за періодом часу</div>
                    </Grid>
                    {
                        range ?
                            <>
                                <Grid item xs={6}>
                                    <LocalizationProvider dateAdapter={AdapterDayjs}>
                                        <DemoContainer components={['DateField']}>
                                            <DateField label="Від" fullWidth onChange={e => setFrom(e)}/>
                                        </DemoContainer>
                                    </LocalizationProvider>
                                </Grid>
                                <Grid item xs={6}>
                                    <LocalizationProvider dateAdapter={AdapterDayjs}>
                                        <DemoContainer components={['DateField']}>
                                            <DateField label="До" fullWidth onChange={e => setTo(e)}/>
                                        </DemoContainer>
                                    </LocalizationProvider>
                                </Grid>
                            </> :
                            <Grid item xs={12}>
                                <LocalizationProvider dateAdapter={AdapterDayjs}>
                                    <DemoContainer components={['DateField']}>
                                        <DateField label="Дата" fullWidth onChange={e => setDate(e)}/>
                                    </DemoContainer>
                                </LocalizationProvider>
                            </Grid>
                    }
                    <Grid item xs={12} align={'center'}>
                        <LoadingButton
                            onClick={handleClick}
                            endIcon={<SendIcon/>}
                            loading={loading}
                            loadingPosition="end"
                            variant="contained"
                            sx={{padding: '10px 30px'}}
                            size={'large'}
                        >
                            <span>Пошук</span>
                        </LoadingButton>
                    </Grid>
                </Grid>
            </div>
            {
                statistic && statistic.length > 0 &&
                <div style={{width: '100%', padding: '0 7% 2%'}}>
                    <div className={styles.resultTitle} style={{paddingBottom: '2%'}}>Статистика</div>
                    <TableContainer component={Paper}>
                        <Table sx={{minWidth: 650}} aria-label="simple table">
                            <TableHead>
                                <TableRow>
                                    <TableCell align="left">Ім'я мікросервіса</TableCell>
                                    <TableCell align="right">Кількість запитів</TableCell>
                                    <TableCell align="right">Кількість результатів</TableCell>
                                    <TableCell align="right">Оброблена кількість даних</TableCell>
                                    <TableCell align="right">Релевантність відповідей</TableCell>
                                </TableRow>
                            </TableHead>
                            <TableBody>
                                {statistic.map((row) => (
                                    <TableRow
                                        key={row.name}
                                        sx={{'&:last-child td, &:last-child th': {border: 0}}}
                                    >
                                        <TableCell component="th" scope="row">
                                            {row.name}
                                        </TableCell>
                                        <TableCell align="right">{row['queries']}</TableCell>
                                        <TableCell align="right">{row['count']}</TableCell>
                                        <TableCell align="right">{row['parsedDataSize']}</TableCell>
                                        <TableCell align="right">{row['percentage']}%</TableCell>
                                    </TableRow>
                                ))}
                            </TableBody>
                        </Table>
                    </TableContainer>
                </div>
            }
            {
                result && result.length > 0 ?
                    <div className={styles.result}>
                        <div className={styles.resultTitle}>Результати пошуку</div>
                        <div className={styles.resultContent}>
                            {
                                result.map((item, index) =>
                                    <ResultWrap key={'result' + index} result={item}/>
                                )
                            }
                        </div>
                    </div> : result && <div className={styles.itemTitleText}>Нічого не знайдено</div>
            }
        </div>
    )
}

const ResultWrap = ({result}) => {
    const item = result['result'];

    return (
        <div className={styles.resultItem}>
            <div className={styles.resultItemContent}>
                <div style={{width: '100%'}}>
                    <div className={styles.itemTitle}>
                        <div className={styles.itemTitleText}>{item['title']}</div>
                        <div className={styles.itemTitleAuthor}>{item['author']}</div>
                    </div>
                    <div className={styles.itemSubTitle}>
                        <div className={styles.itemSubTitleText}>
                            {new Date(item.date).toDateString()}
                        </div>
                        <div className={styles.itemSubTitleText}>{item['keyWords']}</div>
                        <div className={styles.itemSubTitleText}>Категорія: {item['category']}</div>
                        <div className={styles.itemSubTitleText}> Мікросервіс: {result['name']} </div>
                    </div>
                    <div className={styles.itemContent}>
                        {item['content']}
                    </div>
                </div>
            </div>
        </div>
    )
}
